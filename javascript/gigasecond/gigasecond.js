(function () {
  var Gigasecond = function (birthday) {
    this.date = function () {
      return new Date(birthday.valueOf() + 1E12);
    };
  };

  module.exports = Gigasecond;
})();