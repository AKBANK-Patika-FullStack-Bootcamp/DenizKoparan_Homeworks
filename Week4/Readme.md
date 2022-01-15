**GET Request**<br/>
Eklenilen gözlük markalarının özellikleri /Brand API ile GET request kullanılarak aşağıdaki görselde görüldüğü gibi çekilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/get1.png)
<br/>
**GET Request With ID**<br/>
Eklenilen gözlük markalarından BrandID si parametreye eşit olanın özelliklerini /Brand/{id} API ile GET request kullanılarak aşağıdaki görselde görüldüğü gibi çekilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/getWithID.PNG)
<br/>
**DB**<br/>
Yapılan işlemler sonrası veritabanındaki veriler aşağıdaki gibidir.
<br/>
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/db1.PNG)
<br/>
**POST Request**<br/>
Eklenilen gözlük markalarına /Brand API ile POST request ve eklenecek olan markanın body bilgisi kullanılarak aşağıdaki görselde görüldüğü gibi farklı marka özellikleri eklenebilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/postSuccess.PNG)
Eğer markalar arasında body'de gönderilen ID bilgisi hali hazırda varsa hata mesajı dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/postWrong.PNG)
<br/>
**DB**<br/>
Yapılan işlemler sonrası veritabanındaki veriler aşağıdaki gibidir.
<br/>
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/db2.PNG)
<br/>
**DELETE Request**<br/>
Eklenilen gözlük markalarına /Brand/{id} API ile DELETE request kullanılarak aşağıdaki görselde görüldüğü gibi seçilen marka özellikleri silinmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/deleteSuccess.PNG)
Eğer markalar arasında parametre olarak gönderilen ID bilgisi yoksa hata mesajı dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/deleteWrong.PNG)
**DB**<br/>
Yapılan işlemler sonrası veritabanındaki veriler aşağıdaki gibidir.
<br/>
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/db3.PNG)
<br/>

**PUT Request**<br/>
Eklenilen gözlük markalarına /Brand API PUT request ve güncellenmek istenen markanın body bilgisi kullanılarak aşağıdaki görselde görüldüğü gibi seçilen marka özellikleri güncellenebilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/putSuccess.PNG)
Eğer markalar arasında bodyde gönderilen ID bilgisi yoksa hata mesajı dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/putWrong.PNG)
<br/>
**DB**<br/>
Yapılan işlemler sonrası veritabanındaki veriler aşağıdaki gibidir.
<br/>
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week4/ScreenShots/db4.PNG)
<br/>

