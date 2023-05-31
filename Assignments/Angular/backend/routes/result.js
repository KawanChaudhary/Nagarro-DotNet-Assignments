const router = require('express').Router();
const Result = require('../database/models/ResultModel');

// Create a new instance of result

router.post('/', async (req, res) => {
  try {
    var availableRecord = await Result.find({ rollNumber: req.body.rollNumber });
    if (availableRecord.length > 0) {
      return res.status(403).json("Roll Number already exist");
    }
    else {
      const result = await Result.create(req.body);
      res.status(201).json(result);
    }
  } catch (err) {
    res.status(500).json(err);
  }
});

// Update an existing result instance

router.put('/:id', async (req, res) => {
  try {
    const result = await Result.findByIdAndUpdate(req.params.id, {
      $set: req.body,
    }, { new: true });
    res.status(200).json(result);
  } catch (err) {
    res.status(500).json(err);
  }
});

// delete an existing result instance

router.delete('/:id', async (req, res) => {
  try {
    const result = await Result.findByIdAndDelete(req.params.id);
    res.status(200).json("Result has been deleted.");
  } catch (err) {
    res.status(500).json(err);
  }
});

// get all results from the database and return them as JSON

router.get('/', async (req, res) => {
  try {
    const results = await Result.find();
    res.status(200).json(results);
  } catch (err) {
    res.status(500).json(err);
  }
});

// get a single result from the database and return it as JSON

router.post('/details', async (req, res) => {
  try {
    const result = await Result.findOne({
      rollNumber: req.body.rollNumber,
      dateOfbirth: req.body.dateOfbirth
    });

    if (result.length > 0) {
      return res.status(404).json("Not found");
    }
    else {
      res.status(200).json(result);
    }

  } catch (err) {
    res.status(500).json(err);
  }
});

// get a single result ny id from the database and return it as JSON

router.get('/:id', async (req, res) => {
  try {
    const result = await Result.findById(req.params.id);
    res.status(200).json(result);
  } catch (err) {
    res.status(500).json(err);
  }
});

module.exports = router;