**GET Request**<br/>
Eklenilen gözlük markalarının özellikleri /Brand API ile GET request kullanılarak aşağıdaki görselde görüldüğü gibi çekilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/get1.png)
<br/>
**GET Request With ID**<br/>
Eklenilen gözlük markalarından BrandID si parametreye eşit olanın özelliklerini /Brand/{id} API ile GET request kullanılarak aşağıdaki görselde görüldüğü gibi çekilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/getWithID.png)
<br/>
**DB**<br/>
Yapılan işlemler sonrası veritabanındaki veriler aşağıdaki gibidir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/db1.png)
<br/>
**POST Request**<br/>
Eklenilen gözlük markalarına /Brand API ile POST request ve eklenecek olan markanın body bilgisi kullanılarak aşağıdaki görselde görüldüğü gibi farklı marka özellikleri eklenebilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/postSuccess.png)
Eğer markalar arasında body'de gönderilen ID bilgisi hali hazırda varsa hata mesajı dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/postWrong.png)
<br/>
**DB**<br/>
Yapılan işlemler sonrası veritabanındaki veriler aşağıdaki gibidir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/db2.png)
<br/>
**PUT Request**<br/>
Eklenilen gözlük markalarına /Brand API PUT request ve güncellenmek istenen markanın body bilgisi kullanılarak aşağıdaki görselde görüldüğü gibi seçilen marka özellikleri güncellenebilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/putSuccess.png)
Eğer markalar arasında bodyde gönderilen ID bilgisi yoksa hata mesajı dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/putWrong.png)
<br/>
**DB**<br/>
Yapılan işlemler sonrası veritabanındaki veriler aşağıdaki gibidir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/db3.png)
<br/>
**DELETE Request**<br/>
Eklenilen gözlük markalarına /Brand/{id} API ile DELETE request kullanılarak aşağıdaki görselde görüldüğü gibi seçilen marka özellikleri silinmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/deleteSuccess.png)
Eğer markalar arasında parametre olarak gönderilen ID bilgisi yoksa hata mesajı dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/deleteWrong.png)
**DB**<br/>
Yapılan işlemler sonrası veritabanındaki veriler aşağıdaki gibidir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/db4.png)
<br/>
