'use strict';

var anagram = function (word) {
  var sortLetters = function(str) {
    return str.split('').sort().join('');
  }

  var isAnagram = function (test) {
    test = test.toLowerCase();
    return test.length == word.length &&
      lower !== test &&
      sorted === sortLetters(test);
  }

  var lower = word.toLowerCase();
  var sorted = sortLetters(lower);

  return {
    matches: function (words) {
      if (arguments.length > 1) {
        words = arguments;
      }
      var anagrams = [];
      for (var i = 0; i < words.length; i++) {
        if (isAnagram(words[i])) {
          anagrams.push(words[i]);
        }
      }
      return anagrams;
    }
  }
};

module.exports = anagram;