function sumFirstLast(array) {
  let firstElement = Number(array[0]);
  let lastElement = Number(array[array.length - 1]);
  let sum = firstElement + lastElement;
  console.log(sum);
}

sumFirstLast([20, 30, 40]);
