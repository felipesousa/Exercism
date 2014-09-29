class Bob
    
  hey: (conversation) ->
    if this.is_silence conversation then return "Fine. Be that way!"
    if this.is_yelling conversation then return "Whoa, chill out!"
    if this.is_question conversation then return "Sure."
    "Whatever."

  is_silence: (conversation) ->
    conversation.trim() == ""

  is_yelling: (conversation) ->
    this.contains_letters(conversation) && 
    conversation.toUpperCase() == conversation

  is_question: (conversation) ->
    conversation.substr(-1) == "?"
    
  contains_letters: (conversation) ->
    conversation.match(/[A-Za-z]/g) != null
    
module.exports = Bob

