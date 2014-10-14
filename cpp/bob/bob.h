#pragma once
#include <string>
#include <boost/algorithm/string.hpp>

#define QUESTION_RESPONSE "Sure.";
#define YELLING_RESPONSE  "Whoa, chill out!";
#define SILENCE_RESPONSE  "Fine. Be that way!";
#define DEFAULT_RESPONSE  "Whatever.";

class bob
{
public:
    static std::string hey( std::string conversation )
    {
        if ( isSilence( conversation ) ) return SILENCE_RESPONSE;
        if ( isYelling( conversation ) ) return YELLING_RESPONSE;
        if ( isQuestion( conversation ) ) return QUESTION_RESPONSE;
        return DEFAULT_RESPONSE;
    }

private:
    static bool isSilence( std::string& conversation )
    {
        return conversation.find_first_not_of( ' ' ) == std::string::npos;
    }

    static bool isYelling( std::string& conversation )
    {
        return boost::to_upper_copy(conversation) == conversation &&
               boost::to_lower_copy(conversation) != conversation;
    }

    static bool isQuestion( std::string& conversation )
    {
        return conversation.back() == '?';
    }
};