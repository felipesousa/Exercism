(function () {
  module.exports = function (birthday) {
    this.date = function () {
      return new Date(birthday.valueOf() + 1E12);
    };
  }
})();