**GET Request**<br/>
Eklenilen gözlük markalarının özellikleri /Brand API ile get request kullanılarak aşağıdaki görselde görüldüğü gibi çekilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week2/GetRequest.PNG)
<br/>
**POST Request**<br/>
Eklenilen gözlük markalarına /Brand API ile post request ve eklenecek olan markanın body bilgisi kullanılarak aşağıdaki görselde görüldüğü gibi farklı marka özellikleri eklenebilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week2/PostRequestSuccess.PNG)
Eğer markalar arasında bodyle gönderilen ID bilgisi hali hazırda varsa null değeri dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week2/PostRequestDuplicateID.PNG)
<br/>
**PUT Request**<br/>
Eklenilen gözlük markalarına /Brand API ile put request ve güncellenmek istenen markanın body bilgisi kullanılarak aşağıdaki görselde görüldüğü gibi seçilen marka özellikleri güncellenebilmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week2/PutRequestSuccess.PNG)
Eğer markalar arasında bodyle gönderilen ID bilgisi yoksa null değeri dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week2/PutRequestNotExistID.PNG)
<br/>
**DELETE Request**<br/>
Eklenilen gözlük markalarına /Brand/{id} API ile delete request kullanılarak aşağıdaki görselde görüldüğü gibi seçilen marka özellikleri silinmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week2/DeleteSuccess.PNG)
Eğer markalar arasında bodyle gönderilen ID bilgisi yoksa null değeri dönmektedir.
![text](https://github.com/AKBANK-Patika-FullStack-Bootcamp/DenizKoparan_Homeworks/blob/main/Week2/DeleteRequestNotExistID.PNG)
