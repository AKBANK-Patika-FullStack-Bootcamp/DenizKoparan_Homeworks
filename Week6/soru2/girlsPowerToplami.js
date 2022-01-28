let numbers = [2, 3, 4];
function girlsPowerToplami(n) {
    sum =  (n / 2) + 3;
    return sum;
  }

let sums = numbers.map(function(n)
{
  return girlsPowerToplami(n);
})
console.log(sums);

 