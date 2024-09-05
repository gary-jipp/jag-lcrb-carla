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

  if (id === "BC000000") {
    res.render("error");
    return;
  }

  if (id === "BC123456") {
    const name = "Stony Island";
    const urls = ["http://www.stonyisland.store"];
    res.render("found", {id, name, urls});
    return;
  }

  const urls = ["http://www.unknown.com"];
  const name = "Black Market Cannabis";
  res.render("notfound", {id, name, urls});
});

app.listen(PORT, () => {
  console.log(`Server started on port ${PORT}!`);
});