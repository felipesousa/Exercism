'use strict';

var hamming = {
  compute: function(dna1, dna2) {
    var diff = 0;
    var max = Math.min(dna1.length, dna2.length);
    for (var i = 0; i < max; i++) {
      if (dna1[i] !== dna2[i]) diff++;
    }
    return diff;
  }
};

module.exports = hamming;