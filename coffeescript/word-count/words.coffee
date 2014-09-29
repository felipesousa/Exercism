class Words

  constructor: (words) ->
    @count = {}
    for word in words.toLowerCase().match(/\w+'\w+|\w+/g)
      if @count[word] is undefined then @count[word] = 0;
      @count[word]++
  
module.exports = Words
