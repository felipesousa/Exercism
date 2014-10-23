var Bob = function() {};

Bob.prototype.hey = function (input) {
  if( is_silence(input) ) return "Fine. Be that way!";
  if( is_yelling(input) ) return "Whoa, chill out!";
  if( is_question(input) ) return "Sure.";
  return "Whatever.";
};

is_silence = function (conversation) {
  return conversation.trim() === "";
};

is_yelling = function (conversation) {
  return conversation.toUpperCase() === conversation && conversation.match(/[A-Z]/);
};

is_question = function (conversation) {
  return conversation.match(/\?$/);
};

module.exports = Bob;
