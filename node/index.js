var express = require('express');
var bodyParser = require('body-parser');

var app = express();

app.use(bodyParser.json({ type: 'text/json' }));

app.post('/', function(req, res) {
  console.log(JSON.stringify(req.body));
  res.send('ok');
});

app.listen(8080);