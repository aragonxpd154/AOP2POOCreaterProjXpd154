const fs = require('fs');

function findBrandWithFewestModels() {
  const rawData = fs.readFileSync('car-list.json');
  const cars = JSON.parse(rawData);

  let fewestModels = Number.MAX_SAFE_INTEGER;
  let brands = [];

  cars.forEach(car => {
    const numModels = car.models.length;
    if (numModels < fewestModels) {
      fewestModels = numModels;
      brands = [car.brand];
    } else if (numModels === fewestModels) {
      brands.push(car.brand);
    }
  });

  if (brands.length === 1) {
    return brands[0];
  } else {
    return brands;
  }
}

console.log(findBrandWithFewestModels());
