class Words

  constructor: (words) ->
    @count = {}
    @addWord word for word in words.toLowerCase().match(/\w+'\w+|\w+/g)
      
  addWord: (word) ->
    if @count[word] is undefined then @count[word] = 0;
    @count[word]++
  
module.exports = Words
