const mongoose = require('mongoose');

const ResultSchema = new mongoose.Schema({
    rollNumber: {
        type: Number,
        required: true,
        min: 1,
        minLength: 1,
    },
    name: {
        type: String,
        required: true,
        trim: true,
    },
    dateOfbirth: {
        type: String,
        required: true,
    },
    score: {
        type: Number,
        required: true,
        min: 0,
    },
},
{ timestamps: true }
);

const Results = mongoose.model("Results", ResultSchema);

module.exports = Results;