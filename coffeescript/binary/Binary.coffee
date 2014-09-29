class Binary
  
  constructor: (string) ->
    @string = if string == clean string then string else "0"
  
  toDecimal: ->
    result = 0
    for digit, i in @string.split('').reverse()
      result += 2**i * digit
    result
    
  clean = (string) ->
    string.replace(/[^01]/, '')
  
module.exports = Binary