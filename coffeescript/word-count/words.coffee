class Words

  constructor: (words) ->
    @count = {}
    for word in words.toLowerCase().match(/\w+'\w+|\w+/g)
      @count[word] = 0 if not @count[word]
      @count[word]++
  
module.exports = Words
