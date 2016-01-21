var Hamming = function () {
  'use strict';

  this.compute = function (dna1, dna2) {
    if (dna1.length !== dna2.length) {
      throw Error('DNA strands must be of equal length.');
    }
    var diff = 0;
    for (var i = 0; i < dna1.length; i++) {
      if (dna1[i] !== dna2[i]) diff++;
    }
    return diff;
  };
}

module.exports = Hamming;