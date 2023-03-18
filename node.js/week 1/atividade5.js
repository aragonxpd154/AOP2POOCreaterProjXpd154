const fs = require('fs');

function getModelsByBrand(brandName) {
  // Carrega o arquivo JSON
  const carList = JSON.parse(fs.readFileSync('car-list.json', 'utf8'));

  // Filtra a marca buscada, ignorando maiúsculas e minúsculas
  const brand = carList.find(
    car => car.brand.toLowerCase() === brandName.toLowerCase()
  );

  // Retorna a lista de modelos, ou um array vazio, caso a marca não seja encontrada
  return brand ? brand.models : [];
}

console.log(getModelsByBrand('Peugeot')); // ["1007", "107", "106", "108", "2008", "205", "205 Cabrio", "206", "206 CC", "206 SW", "207", "207 CC", "207 SW", "306", "307", "307 CC", "307 SW", "308", "308 CC", "308 SW", "309", "4007", "4008", "405", "406", "407", "407 SW", "5008", "508", "508 SW", "605", "806", "607", "807", "Bipper", "RCZ"]
console.log(getModelsByBrand('honda')); // []
console.log(getModelsByBrand('Renault')); // ["Captur", "Clio", "Clio Grandtour", "Espace", "Express", "Fluence", "Grand Espace", "Grand Modus", "Grand Scenic", "Kadjar", "Kangoo", "Kangoo Express", "Koleos", "Laguna", "Laguna Grandtour", "Latitude", "Mascott", "Mégane", "Mégane CC", "Mégane Combi", "Mégane Grandtour", "Mégane Coupé", "Mégane Scénic", "Scénic", "Talisman", "Talisman Grandtour", "Thalia", "Twingo", "Wind", "Zoé"]
