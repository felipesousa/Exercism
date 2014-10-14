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

        boost::sregex_token_iterator i( normalized.begin(), normalized.end(), regex );
        boost::sregex_token_iterator end;
        while ( i != end )
        {
            std::string word = *i++;
            if ( count.count( word ) == 0 )
            {
                count[word] = 0;
            }
            count[word]++;
        }
        return count;
    }
};