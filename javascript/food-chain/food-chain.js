'use strict';

(function () {

  module.exports = function () {

    var food = ['fly', 'spider', 'bird', 'cat', 'dog', 'goat', 'cow', 'horse'];

    var lines = [
        "It wriggled and jiggled and tickled inside her.",
        "How absurd to swallow a bird!",
        "Imagine that, to swallow a cat!",
        "What a hog, to swallow a dog!",
        "Just opened her throat and swallowed a goat!",
        "I don't know how she swallowed a cow!",
        "She's dead, of course!"
    ];

    this.verse = function (v) {
      v = v - 1;
      var song = 'I know an old lady who swallowed a ' + food[v] + '.\n';
      if (v >= 1) song += lines[v - 1] + '\n';

      if (v === 7) return song; // Last verse kills her

      for (var j = v; j > 0; j--) {
        song += 'She swallowed the ' + food[j] + ' to catch the ' + food[j - 1];
        if (j === 2) {
          song += ' that wriggled and jiggled and tickled inside her';
        }
        song += '.\n';
      }
      return song + "I don't know why she swallowed the fly. Perhaps she'll die.\n";
    };

    this.verses = function (i, j) {
      var song = '';
      for (var v = i; v <= j; v++) {
        song += this.verse(v) + '\n';
      }
      return song;
    };
  };
})();