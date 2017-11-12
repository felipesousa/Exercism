#pragma once
#include <string>
#include <iostream>
#include <fstream>
#include <istream>
#include <map>
#include <algorithm>
#include <iterator>
#include <regex>
#include <boost/algorithm/string/case_conv.hpp>

namespace word_count
{
    std::map<std::string, int> words( const std::string& sentence )
    {
        static const std::regex regex( "\\w+'\\w+|\\w+" );
        std::map<std::string, int> count;
        std::string normalized = boost::to_lower_copy( sentence );

        std::sregex_token_iterator word( normalized.begin(), normalized.end(), regex );
        std::sregex_token_iterator end;
        while ( word != end )
        {
            count[*word++]++;
        }
        return count;
    }
};