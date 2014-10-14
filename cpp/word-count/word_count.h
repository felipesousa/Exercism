#pragma once
#include <string>
#include <map>
#include <boost/regex.hpp>
#include <boost/algorithm/string.hpp>

namespace word_count
{
    std::map<std::string, int> words( const std::string& sentence )
    {
        static const boost::regex regex( "\\w+'\\w+|\\w+" );
        std::map<std::string, int> count;
        std::string normalized = boost::to_lower_copy( sentence );

        boost::sregex_token_iterator word( normalized.begin(), normalized.end(), regex );
        boost::sregex_token_iterator end;
        while ( word != end )
        {
            count[*word++]++;
        }
        return count;
    }
};