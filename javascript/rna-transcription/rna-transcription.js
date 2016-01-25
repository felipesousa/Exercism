(function () {
  module.exports = function (dna) {
    this.toRna = function (dna) {
      var rna = '';
      for(var i=0; i<dna.length; i++) {
        var d = dna[i].toUpperCase();
        rna += complements[d] || '';
      }
      return rna;
    }

    var complements = { G: 'C', C: 'G', T: 'A',  A: 'U' };
  };
})();