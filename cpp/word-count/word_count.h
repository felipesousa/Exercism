#pragma once
#include <string>
#include <map>
#include <boost/regex.hpp>
#include <boost/algorithm/string.hpp>

class word_count
{
public:
    static std::map<std::string, int> words( const std::string& sentence )
    {
        static const boost::regex regex( "\\w+'\\w+|\\w+" );
        std::map<std::string, int> count;
        std::string normalized = boost::to_lower_copy( sentence );

        boost::sregex_token_iterator i( normalized.begin(), normalized.end(), regex, 0 );
        boost::sregex_token_iterator end;
        for ( ; i != end; ++i )
        {
            std::string word( i->first, i->second );
            if ( count.count( word ) == 0 )
            {
                count[word] = 0;
            }
            count[word]++;
        }
        return count;
    }
};