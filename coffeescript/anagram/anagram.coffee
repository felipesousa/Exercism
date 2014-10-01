class Anagram

  # Constructs an Anagram class to find anagrams in lists of words
  constructor: (anagram) ->    
    @anagram = anagram.toLowerCase
    @sortedAnagram = sort @anagram
    
  # Given a list of words, finds those that are anagrams for
  # the word the class was constructed with.
  match: (words) ->
    word for word in words when word and word.trim() is not '' and isAnagram word.toLowerCase
    
  # Determines if a word is an anagram 
  # of the word passed in to the constructor.
  isAnagram = (word) ->
    word.length == @anagram.length and not arraysEqual(word, @anagram) and arraysEqual(sort word, @sortedAnagram)
 
  # Sorts a string alphabetically   
  sort = (str) ->
    c = str.split('').sort()
    
  arraysEqual = (a, b) ->
    if a == b then return true;
    if a is null or b is null then return false;
    if a.length != b.length then return false;
    for c, i in a
      if c != b[i] then return false;
    true
    

module.exports = Anagram
