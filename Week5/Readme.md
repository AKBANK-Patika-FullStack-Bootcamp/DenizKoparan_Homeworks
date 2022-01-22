**DB**<br/>
Kullanıcı bilgileri tablosu için veri tabanının başlangıçtaki durumu aşağıdaki gibidir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/database1.PNG)
<br/>
**create API**<br/>
Body'de gönderilen username, password bilgileriyle veri tabanına kayıt işlemi gerçekleşir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/create.PNG)
<br/>
**DB**<br/>
Yapılan işlem sonrasında kullanıcı bilgileri tablosu için veritabanındaki veriler aşağıdaki gibidir.
<br/>
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/database2.PNG)
<br/>
**login API**<br/>
Header'da gönderilen username, password bilgileri için bir bearer token oluşturur.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/login.PNG)
<br/>
**Token ile API'ye istek atma**<br/>
Alınan token ile veri tabanında kayıtlı kullanıcıları getiren API'ye istek attığımızda sonuç aşağıdaki gibidir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/usersWithToken.PNG)
<br/>
Eğer token bilgisi girilmez veya hatalı bir biçimde girilirse aşağıdaki görselde görüldüğü gibi, istek geri çevrilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/unauthorizedRequest.PNG)
<br/>
<br/>
**Paging Örneği**
<br/>
<br/>
**DB**
Brand Tablosunun Veritabanında Kayıtlı Verileri aşağıdaki gibidir;
<br/>
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/brandsDB.PNG)
<br/>
**Paging işlemleri**<br/>
pageNumber = 0 ve pageSize = 1 olarak gönderilen isteğe karşı gelen cevap aşağıdaki gibidir;
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/pagingExample1.PNG)
<br/>
pageNumber = 1 ve pageSize = 3 olarak gönderilen isteğe karşı gelen cevap aşağıdaki gibidir;
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week5/ScreenShots/pagingExample2.PNG)
<br/>