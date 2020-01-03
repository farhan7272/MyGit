var express = require('express');
var mongoose = require('mongoose');
var bodyparser = require('body-parser');

// var db =  mongoose.connect('mongodb://localhost:27017/local');

var promise = mongoose.connect('mongodb://localhost:27017/local', {
    useMongoClient: true
});

var Book = require('./models/bookModel');

var app = express();
app.use(bodyparser.json());
app.use(bodyparser.urlencoded({extended:true}));

var port = process.env.PORT || 3000;

var bookRouter = require('./Routes/bookRoutes')(Book);

app.use('/api', bookRouter);

app.get('/', function (req, res) {
    res.send('welcome to my api');
});

app.listen(port, function () {
    console.log('Running server at ' + port);
});