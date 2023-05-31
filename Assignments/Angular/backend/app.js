const express = require('express');
const app = express();

const Results = require('./routes/result');

const mongoose = require('./database/mongoose');

// Request
/*
CORS = cross orgin request security
frontend -- port 4200
backend -- port 3000
*/

app.use((req, res, next)=>{
    res.header("Access-Control-Allow-Origin", "*");
    res.header("Access-Control-Allow-Methods", "GET, POST, HEAD, OPTIONS, PUT, PATCH, DELETE");
    res.header("Access-Control-Allow-Headers", "Origin, X-Requested-With, Content-Type, Accept");;
    next();
});

/*
Results: Create, Update, ReadOne, ReadAll, Delete
*/

app.use(express.json());

app.use("/result", Results)

app.listen(3000, ()=> console.log("Server connecetd on port 3000"));
