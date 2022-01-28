const kopek = require('./Kopek.js') ;
const kopekBakimUtility = require('./KopekBakimUtility');

let kopekIlgiSaati = kopek.dog.weight * kopekBakimUtility.kopekBakimSaati;
console.log("Kopek adi : " + kopek.dog.name);
console.log("Kopek boyu : " + kopek.dog.length + "cm");
kopekBakimUtility.kopegiTemizle();
console.log("Kopek ilgi saati : " + kopekIlgiSaati);