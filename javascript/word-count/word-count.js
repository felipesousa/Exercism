'use strict';

module.exports = function (phrase) {
  var counts = {};
  phrase.split(/\s/).forEach(function (word) {
    counts[word] = counts.hasOwnProperty(word) ? counts[word] + 1 : 1;
  });
  return counts;
}