const fs = require('fs');

function brandWithMostModels(filename) {
  // Passo 1: Ler o arquivo JSON
  const carList = JSON.parse(fs.readFileSync(filename, 'utf8'));

  // Passo 2: Criar um objeto para armazenar o número de modelos de cada marca
  const brandCount = {};

  // Passo 3: Iterar sobre as marcas e modelos e contar o número de modelos de cada marca
  for (const car of carList) {
    const brand = car.brand;
    const models = car.models;
    if (!brandCount[brand]) {
      brandCount[brand] = models.length;
    } else {
      brandCount[brand] += models.length;
    }
  }

  // Passo 4: Encontrar a marca com o maior número de modelos
  let maxBrand = '';
  let maxCount = -1;
  for (const brand in brandCount) {
    if (brandCount[brand] > maxCount) {
      maxBrand = brand;
      maxCount = brandCount[brand];
    }
  }

  // Passo 5: Retornar o nome da marca ou uma lista de marcas em caso de empate
  const maxBrands = [];
  for (const brand in brandCount) {
    if (brandCount[brand] === maxCount) {
      maxBrands.push(brand);
    }
  }
  return maxBrands.length > 1 ? maxBrands : maxBrand;
}

console.log(brandWithMostModels('car-list.json'));
