const mongoose = require('mongoose');
mongoose.Promise = global.Promise;

mongoose.connect('mongodb+srv://admin:admin@resultmanagementsystem.z0ks8ro.mongodb.net/?retryWrites=true&w=majority')
.then(() => console.log("Database Connected"))
.catch((error) => console.log(error));

module.exports = mongoose;