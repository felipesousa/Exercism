class Bob

  QUESTION_RESPONSE = "Sure."
  YELLING_RESPONSE  = "Whoa, chill out!"
  SILENCE_RESPONSE  = "Fine. Be that way!"
  DEFAULT_RESPONSE  = "Whatever."
    
  hey: (conversation) ->
    DEFAULT_RESPONSE  
    
module.exports = Bob

