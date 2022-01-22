using Microsoft.AspNetCore.Mvc;
using Models;
using Entities;
using MySqlX.XDevAPI.Common;
using Microsoft.AspNetCore.Authorization;

namespace Odev.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {

        GlassesContext dbOperations = new GlassesContext();

        /*[HttpGet()]
        public List<Brand> GetBrands()
        {
            List<Brand> resultList = dbOperations.Brand.ToList();//butun tabloyu donduruyor
            return resultList;
        }*/

        [HttpGet("{id}")]
        public List<Brand> GetBrand(int id)
        {
            List<Brand> resultList = dbOperations.Brand.Where(k => k.BrandID == id).ToList();//id si verilen brandi donduruyor
            return resultList;
        }

        [HttpPost]
        public string PostBrand(Brand brand)
        {
            Brand b = dbOperations.Brand.Where(k => k.BrandID == brand.BrandID).FirstOrDefault();//Id si ile ekleme yapilirken eger id varsa hata vermesi icin

            if (b == null)//Eger bos donuyorsa o id daha onceden kaydedilmedi demektir.
            {
                CommitAddingBrand(brand);
                return "Yeni eleman eklendi";
            }
                return "Eklenemedi";
        }


        [HttpDelete("{id}")]
        public string DeleteBrand(int id)
        {
            Brand b = dbOperations.Brand.Where(k => k.BrandID == id).FirstOrDefault();//silme yapilirken eger girilen id yoksa hata vermesi icin

            if (b == null)//Eger bos donuyorsa o id daha onceden kaydedilmedi demektir.
            {
                return "Girilen id bulunamadi.";
            }
            CommitDeletingBrand(b);
            return "Silme islemi basariyla gerceklestirildi.";

        }


        [HttpPut]
        public string UpdateBrand(Brand brand)
        {
            Brand b = dbOperations.Brand.Where(k => k.BrandID == brand.BrandID).FirstOrDefault();//guncelleme yapilirken eger girilen id yoksa hata vermesi icin

            if (b == null)//Eger bos donuyorsa o id daha onceden kaydedilmedi demektir.
            {
                return "Girilen Gozluk bulunamadi.";
            }
            return CommitUpdatingBrand(brand, b);

        }

        private bool CommitAddingBrand(Brand brand)
        {
            try
            {
                dbOperations.Brand.Add(brand);
                dbOperations.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
            
        }

        private bool CommitDeletingBrand(Brand brand)
        {
            try
            {
                dbOperations.Brand.Remove(brand);
                dbOperations.SaveChanges();
                return true;
            }
            catch (Exception ex)
            {
                return false;
            }
        }

        private string CommitUpdatingBrand(Brand brand, Brand b)
        {
            try
            {
                dbOperations.Entry(b).CurrentValues.SetValues(brand);
                dbOperations.SaveChanges();
                return "Guncelleme islemi tamamlandi.";
            }
            catch (Exception ex)
            {
                return ex.ToString();
            }
        }

        private List<BrandWithPrices> innerjoin()
        { //Brand ile Prices tablolarini birlestirmek icin
            return dbOperations.Brand.Join(dbOperations.Prices, u => u.BrandID, a => a.BrandID,
                (brand,price) => new BrandWithPrices { GlassName = brand.GlassName, GlassColor = brand.GlassColor, GlassType = brand.GlassType, GlassModel = brand.GlassModel, Price = price.Price }).ToList();
        }

        public void CreateLogin(APIAuthority loginUser)
        {
            dbOperations.APIAuthority.Add(loginUser);
            dbOperations.SaveChanges();
        }

        public APIAuthority GetLogin(APIAuthority loginUser)
        {
            APIAuthority? user = new APIAuthority();
            if (!string.IsNullOrEmpty(loginUser.username) && !string.IsNullOrEmpty(loginUser.password) )
            {
                user = dbOperations.APIAuthority.FirstOrDefault(m => m.username == loginUser.username && m.password == loginUser.password);
            }

            return user;
        }

        [Authorize]
        [HttpGet]
        public List<APIAuthority> GetUser()//authentication with bearer token
        {

            return dbOperations.GetUsers();
        }


        [HttpGet("/brand/GetUserPaging")]
        public IActionResult GetUserPaging([FromQuery] OwnerParameters ownerParameters)//paging method for brands table
        {
            var owners = dbOperations.GetBrands() 
           .Skip(ownerParameters.PageNumber)
           .Take(ownerParameters.PageSize)
           .ToList();


            return Ok(owners);
        }

    }
}