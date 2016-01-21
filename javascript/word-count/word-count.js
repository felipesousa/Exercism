'use strict';

(function () {
  module.exports = function () {

    this.count = function (phrase) {
      var counts = {};
      phrase.split(/\s/).forEach(function (word) {
        if (word !== undefined && word.length > 0) {
          counts[word] = counts.hasOwnProperty(word) ? counts[word] + 1 : 1;
        }
      });
      return counts;
    };
  };
})();