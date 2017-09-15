<?xml version="1.0"?>
<GarbageCan xmlns:xsi="http://www.w3.org/2001/XMLSchema-instance" xmlns:xsd="http://www.w3.org/2001/XMLSchema">
  <FilterList>
    <Filter>
      <Name>MSTest Result</Name>
      <RegularExpression>^TestResults$</RegularExpression>
      <Include />
      <Exclude />
      <ContainFile>false</ContainFile>
      <ContainDirectory>true</ContainDirectory>
      <IsChecked>true</IsChecked>
    </Filter>
    <Filter>
      <Name>Resharper</Name>
      <RegularExpression>(^_resharper\.|\.resharper\.user$)</RegularExpression>
      <Include />
      <Exclude />
      <ContainFile>true</ContainFile>
      <ContainDirectory>true</ContainDirectory>
      <IsChecked>true</IsChecked>
    </Filter>
    <Filter>
      <Name>Symbol</Name>
      <RegularExpression>\.pdb$</RegularExpression>
      <Include />
      <Exclude>D:\NotBackedUp\symbols\,D:\NotBackedUp\local_symbols\,</Exclude>
      <ContainFile>false</ContainFile>
      <ContainDirectory>true</ContainDirectory>
      <IsChecked>true</IsChecked>
    </Filter>
    <Filter>
      <Name>Ncrunch</Name>
      <RegularExpression>(.ncrunchsolution$|.ncrunchsolution.user$|.crunchsolution.cache$)</RegularExpression>
      <Include />
      <Exclude />
      <ContainFile>false</ContainFile>
      <ContainDirectory>false</ContainDirectory>
      <IsChecked>true</IsChecked>
    </Filter>
    <Filter>
      <Name>CleanDebug</Name>
      <RegularExpression>(^Debug$|^Release$)</RegularExpression>
      <Include>D:\NotBackedUp\TFSWork\,</Include>
      <Exclude />
      <ContainFile>false</ContainFile>
      <ContainDirectory>true</ContainDirectory>
      <IsChecked>true</IsChecked>
    </Filter>
    <Filter>
      <Name>VSGarbage</Name>
      <RegularExpression>\.sdf$</RegularExpression>
      <Include />
      <Exclude />
      <ContainFile>true</ContainFile>
      <ContainDirectory>false</ContainDirectory>
      <IsChecked>true</IsChecked>
    </Filter>
  </FilterList>
</GarbageCan>