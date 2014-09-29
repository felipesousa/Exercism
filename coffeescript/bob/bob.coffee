###
Bob is a lackadaisical teenager.
###
class Bob
    
  ###
  Get's Bob's response to conversation  
  @conversation - What you say to Bob
  @returns - What Bob says back to you
  ###
  hey: (conversation) ->
    switch
      when is_silence conversation then "Fine. Be that way!"
      when is_yelling conversation then "Whoa, chill out!"
      when is_question conversation then "Sure."
      else "Whatever."

  is_silence = (conversation) ->
    conversation.trim() == ""

  is_yelling = (conversation) ->
    conversation.match(/[A-Z]/) && !conversation.match(/[a-z]/)

  is_question = (conversation) ->
    conversation.match(/\?$/)
    
  contains_letters = (conversation) ->
    conversation.match(/[A-Za-z]/)
    
module.exports = Bob

