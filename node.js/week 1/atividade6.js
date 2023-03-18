const express = require('express');
const carList = require('./car-list.json');

const app = express();

// Item 1 - /marcas/maisModelos
app.get('/marcas/maisModelos', (req, res) => {
  const sorted = carList.sort((a, b) => b.models.length - a.models.length);
  const result = sorted[0].brand;
  res.send(result);
});

// Item 2 - /marcas/menosModelos
app.get('/marcas/menosModelos', (req, res) => {
  const sorted = carList.sort((a, b) => a.models.length - b.models.length);
  const result = sorted[0].brand;
  res.send(result);
});

// Item 3 - /marcas/listaMaisModelos/X
app.get('/marcas/listaMaisModelos/:X', (req, res) => {
  const { X } = req.params;
  const result = carList.filter(car => car.brand === X)[0].models;
  res.send(result);
});

// Item 4 - /marcas/listaMenosModelos/X
app.get('/marcas/listaMenosModelos/:X', (req, res) => {
  const { X } = req.params;
  const result = carList.filter(car => car.brand === X)[0].models;
  res.send(result);
});

// Item 5 - /marcas/listaModelos
app.post('/marcas/listaModelos', (req, res) => {
  const { nomeMarca } = req.body;
  const result = carList.filter(car => car.brand === nomeMarca)[0].models;
  res.send(result);
});

app.listen(3000, () => {
  console.log('Server started on port 3000');
});
