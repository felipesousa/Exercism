'use strict';

(function () {
  module.exports = function () {

    this.hey = function (input) {
      if (is_silence(input)) return "Fine. Be that way!";
      if (is_yelling(input)) return "Whoa, chill out!";
      if (is_question(input)) return "Sure.";
      return "Whatever.";
    };

    var is_silence = function (conversation) {
      return conversation.trim() === "";
    };

    var is_yelling = function (conversation) {
      return conversation.toUpperCase() === conversation &&
             conversation.toLowerCase() !== conversation;
    };

    var is_question = function (conversation) {
      return conversation.match(/\?$/);
    };
  };
})();