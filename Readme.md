# Bonet XXI Project

The goal of this project is to digitize Bonet's dictionary content, the *Dictionnaire annamite-français* 大南國音字彙合解大法國音 and hence transform it from a 19<sup>th</sup> century artifact to a 21<sup>th</sup> century resource.

The interesting point of this dictionary is it features the former Vietnamese writing system *chữ nôm* in addition to the current *chữ quốc* writing. Moreover, it contains French translations, which will help the Vietnamese-French pair that is poorly endowed, NLP speaking.

## Content

For now only the Vietnamese part is copied from the dictionary in plain text files. French will be added later with OCR help and a new XML-basedfile will be created.

### File Structure

Entries from the dictionary are separated by a blank line. One headword or compound word per line.
*Chữ quốc* first, then *chữ nôm*, as in the original dictionary.
Compound words belonging to an entry are placed a the file were the corresponding headword belong even if appearing on the next page.

## Notes

View file [notes.txt](notes.txt).