const fs = require('fs');

function getLeastPopularBrands(x) {
  const carList = JSON.parse(fs.readFileSync('car-list.json', 'utf8'));

  const brandModelsCount = carList.reduce((acc, car) => {
    acc[car.brand] = car.models.length;
    return acc;
  }, {});

  const sortedBrands = Object.keys(brandModelsCount).sort((a, b) => {
    if (brandModelsCount[a] !== brandModelsCount[b]) {
      return brandModelsCount[a] - brandModelsCount[b];
    }
    return a.localeCompare(b);
  });

  return sortedBrands.slice(0, x).map(brand => {
    return `${brand} - ${brandModelsCount[brand]}`;
  });
}

console.log(getLeastPopularBrands(5));
