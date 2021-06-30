# Bonet XXI Project

The goal of this project is to digitize Bonet's dictionary content, the *Dictionnaire annamite-français* 大南國音字彙合解大法國音 and hence transform it from a 19<sup>th</sup> century artifact to a 21<sup>th</sup> century resource.

The interesting point of this dictionary is it features the former Vietnamese writing system *chữ nôm* in addition to the current *quốc ngữ* writing. Moreover, it contains French translations, which will help the Vietnamese-French pair that is poorly endowed, NLP speaking.

## Content

For now only the Vietnamese part is copied from the dictionary in plain text files. French will be added later with OCR help and a new XML-basedfile will be created.

Every Vietnamese word appearing in an entry is copied in the file, even if not a compound word of the current entry. Compound words use the nôm character of the entry instead of the shortcut 〇.

### File Structure

Entries from the dictionary are separated by a blank line. One headword or compound word per line.
*Quốc ngữ* first, then *chữ nôm*, as in the original dictionary.
Compound words belonging to an entry are placed a the file were the corresponding headword belong even if appearing on the next page.

## License

This work is placed under Creative Commons Attribution 4.0 International ([CC BY 4.0](https://creativecommons.org/licenses/by/4.0/)) license.

Prefered attribution form is:  
Original data compiled by Jean Bonet. Digitized by Louis Lecailliez.

## Notes

View file [notes.txt](notes.txt).