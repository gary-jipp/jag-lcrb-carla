require('dotenv').config();
const express = require("express");
const morgan = require('morgan');


const PORT = process.env.PORT || 8080;

const app = express();
app.set("view engine", "ejs");
app.use(morgan('common'));
app.use(express.static(__dirname + '/public'));

//  Version/Heartbeat Endpoint
app.get("/version", (req, res) => {
  res.json({version: process.env.BUILD_NUMBER});
});

app.get("/verify/:id", (req, res) => {
  const id = req.params.id;
  const url = "https://myweedstore.ca";

  if (id === "BC123456") {
    res.render("found", {id, url});
    return;
  }

  res.render("notfound", {id, url});
});

app.listen(PORT, () => {
  console.log(`Server started on port ${PORT}!`);
});