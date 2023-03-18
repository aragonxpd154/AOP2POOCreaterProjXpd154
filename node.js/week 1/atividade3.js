const fs = require('fs');

function getModelCountByBrand(x) {
  const cars = JSON.parse(fs.readFileSync('car-list.json'));
  const modelCounts = new Map();
  for (const car of cars) {
    const brand = car.brand;
    const count = car.models.length;
    modelCounts.set(brand, (modelCounts.get(brand) || 0) + count);
  }
  const sortedCounts = Array.from(modelCounts.entries()).sort(
    (a, b) => b[1] - a[1] || a[0].localeCompare(b[0])
  );
  const topXCounts = sortedCounts.slice(0, x);
  const result = topXCounts.map(([brand, count]) => `${brand} - ${count}`);
  return result;
}

console.log(getModelCountByBrand(5));
