using Microsoft.AspNetCore.Mvc;
using Odev.Models;

namespace Odev.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class BrandController : ControllerBase
    {
        [HttpGet()]
        public List<Brand> GetBrand()
        {
            List<Brand> resultList = new List<Brand>();
            resultList = AddBrand();
            return resultList;
        }
        public List<Brand> AddBrand()
        {
            List<Brand> lst = new List<Brand>();
            lst.Add(new Models.Brand { BrandId = 1, GlassColor = "Brown", GlassModel = "Drop", GlassName = "Guess", GlassType = "Old" });
            lst.Add(new Models.Brand { BrandId = 2, GlassColor = "Black", GlassModel = "BobMarley", GlassName = "DolceGabbana", GlassType = "New" });
            return lst;
        }
        [HttpDelete("{id}")]
        public List<Brand> DeleteBrand(int id)
        {
            List<Brand> GlassList = new List<Brand>();
            GlassList = AddBrand();
            Brand result = new Brand();
            result = GlassList.FirstOrDefault(x => x.BrandId == id);
            if(result == null)
            {
                return null;
            }
            else
            {
                GlassList.Remove(result);
                return GlassList;
            }
        }

        [HttpPost]
        public List<Brand> PostBrand(Brand brand)
        {
            List<Brand> GlassList = new List<Brand>();
            GlassList = AddBrand();
            
            if (GlassList.FirstOrDefault(x => x.BrandId == brand.BrandId) == null)
            {
                GlassList.Add(brand);
                return GlassList;
            }
            else
            {
                return null;
            }
        }

        [HttpPut]
        public List<Brand> UpdateBrand(Brand brand)
        {
            List<Brand> GlassList = new List<Brand>();
            GlassList = AddBrand();
            Brand result = GlassList.FirstOrDefault(x => x.BrandId == brand.BrandId);
            if (result == null)
            {
                return null;
            }
            else
            {
                int index = GlassList.IndexOf(result);
                GlassList[index] = brand;
                return GlassList;
            }
        }




    }
}