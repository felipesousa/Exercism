'use strict';

(function () {

  module.exports = function (word) {
    this.matches = function (words) {
      var anagrams = [];

      if (arguments.length === 1 && typeof (words) === "string") {
        words = [words];
      } else if (arguments.length > 1) {
        words = arguments;
      }

      for (var i = 0; i < words.length; i++) {
        if (isAnagram(words[i])) {
          anagrams.push(words[i]);
        }
      }

      return anagrams;
    }

    var sortLetters = function (str) {
      return str.split('').sort().join('');
    }

    var isAnagram = function (test) {
      test = test.toLowerCase();
      return lower !== test && sorted === sortLetters(test);
    }

    var lower = word.toLowerCase();
    var sorted = sortLetters(lower);
  };
})();