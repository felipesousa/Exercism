class Binary
  
  constructor: (string) ->
    @string = string.replace(/[^01]/, '')
  
  toDecimal: ->
    result = 0
    for digit, i in @string.split('').reverse()
      result += parseInt(digit) << i
    result      
  
module.exports = Binary