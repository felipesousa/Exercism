class Anagram

  # Constructs an Anagram class to find anagrams in lists of words
  constructor: (anagram) ->
    @anagram = anagram.toLowerCase()
    @sortedAnagram = sort @anagram

  # Given a list of words, finds those that are anagrams for
  # the word the class was constructed with.
  match: (words) ->
    word.toLowerCase() for word in words when word and
      word.trim() isnt '' and
      @isAnagram word.toLowerCase()

  # Determines if a word is an anagram
  # of the word passed in to the constructor.
  isAnagram: (word) ->
    word isnt @anagram and sort(word) is @sortedAnagram

  # Sorts a string alphabetically
  sort = (str) ->
    str.split('').sort().join('')

module.exports = Anagram
