Words = require "./words"

describe "Words", ->
  it "counts one word", ->
    words = new Words "word"
    expect(words.count).toEqual
      word: 1

  it "counts one of each", ->
    words = new Words "one of each"
    expect(words.count).toEqual
      one: 1
      of: 1
      each: 1

  it "counts multiple occurrences", ->
    words = new Words "one fish two fish red fish blue fish"
    expect(words.count).toEqual
      one: 1
      fish: 4
      two: 1
      red: 1
      blue: 1

  it "ignores punctuation", ->
    words = new Words "car : carpet as java : javascript!!&@$%^&"
    expect(words.count).toEqual
      car: 1
      carpet: 1
      as: 1
      java: 1
      javascript: 1

  it "includes numbers", ->
    words = new Words "testing, 1, 2 testing"
    expect(words.count).toEqual
      testing: 2
      1: 1
      2: 1

  it "normalizes case", ->
    words = new Words "go Go GO"
    expect(words.count).toEqual
      go: 3
  
  it "handles apostrophes", ->                      
    words = new Words "First: don't laugh. Then: don't cry."
    expect(words.count).toEqual
            first: 1
            "don't": 2
            laugh: 1
            then:  1
            cry:   1
      
  it "handles free standing apostrophes", ->
    words = new Words "go ' Go '' GO"
    expect(words.count).toEqual
      go: 3
      
  it "handles apostrophes as quotes", ->
    words = new Words "She said, 'let's meet at twelve o'clock'"
    expect(words.count).toEqual
      she: 1
      said: 1
      "let's": 1
      meet: 1
      at:1
      twelve: 1
      "o'clock": 1
