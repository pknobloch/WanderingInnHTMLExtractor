# WanderingInnHTMLExtractor
A quick utility to help me extract the inner HTML from a web-novel I'm reading. The input and output path is **hard-coded** (yeah, I know - it's naughty). I used http://pandoc.org to stitch the HTML together to create an EPUB file to read on my phone.

Maybe this will help someone (or me when Volume 6 is complete).

Here's the list of the raw files that I used:

```
wget https://wanderinginn.com/2018/07/10/5-00/ -O 01.htm
wget https://wanderinginn.com/2018/07/14/5-01/ -O 02.htm
wget https://wanderinginn.com/2018/07/17/5-02/ -O 03.htm
wget https://wanderinginn.com/2018/07/21/5-03/ -O 04.htm
wget https://wanderinginn.com/2018/07/21/5-04/ -O 05.htm
wget https://wanderinginn.com/2018/07/24/5-05/ -O 06.htm
wget https://wanderinginn.com/2018/07/27/5-06-m/ -O 07.htm
wget https://wanderinginn.com/2018/07/28/5-07/ -O 08.htm
wget https://wanderinginn.com/2018/07/31/5-08/ -O 09.htm
wget https://wanderinginn.com/2018/08/04/interlude-flos/ -O 10.htm
wget https://wanderinginn.com/2018/08/07/5-09-e/ -O 11.htm
wget https://wanderinginn.com/2018/08/11/5-10-e/ -O 12.htm
wget https://wanderinginn.com/2018/08/14/5-11-e/ -O 13.htm
wget https://wanderinginn.com/2018/08/18/5-12/ -O 14.htm
wget https://wanderinginn.com/2018/08/21/5-13/ -O 15.htm
wget https://wanderinginn.com/2018/08/25/5-14/ -O 16.htm
wget https://wanderinginn.com/2018/08/28/5-15/ -O 17.htm
wget https://wanderinginn.com/2018/09/01/5-16-s/ -O 18.htm
wget https://wanderinginn.com/2018/09/01/5-17-s/ -O 19.htm
wget https://wanderinginn.com/2018/09/04/5-18-s// -O 20.htm
wget https://wanderinginn.com/2018/09/08/5-19-g/ -O 21.htm
wget https://wanderinginn.com/2018/09/11/5-20-g/ -O 22.htm
wget https://wanderinginn.com/2018/09/15/5-21-e/ -O 23.htm
wget https://wanderinginn.com/2018/09/18/5-22-g/ -O 24.htm
wget https://wanderinginn.com/2018/09/22/5-23-g/ -O 25.htm
wget https://wanderinginn.com/2018/09/29/5-24-l/ -O 26.htm
wget https://wanderinginn.com/2018/10/02/5-25-l/ -O 27.htm
wget https://wanderinginn.com/2018/10/06/5-26-l/ -O 28.htm
wget https://wanderinginn.com/2018/10/09/5-27/ -O 29.htm
wget https://wanderinginn.com/2018/10/13/5-28/ -O 30.htm
wget https://wanderinginn.com/2018/10/16/5-29/ -O 31.htm
wget https://wanderinginn.com/2018/10/20/5-30-g/ -O 32.htm
wget https://wanderinginn.com/2018/10/23/5-31-g/ -O 33.htm
wget https://wanderinginn.com/2018/10/27/5-32-g/ -O 34.htm
wget https://wanderinginn.com/2018/10/30/5-33-b/ -O 35.htm
wget https://wanderinginn.com/2018/11/01/interlude-blackmage/ -O 36.htm
wget https://wanderinginn.com/2018/11/03/5-34/ -O 37.htm
wget https://wanderinginn.com/2018/11/06/5-35-h/ -O 38.htm
wget https://wanderinginn.com/2018/11/10/5-36/ -O 39.htm
wget https://wanderinginn.com/2018/11/13/5-37-g/ -O 40.htm
wget https://wanderinginn.com/2018/11/17/5-38/ -O 41.htm
wget https://wanderinginn.com/2018/11/20/5-39// -O 42.htm
wget https://wanderinginn.com/2018/11/24/5-40 -O 43.htm
wget https://wanderinginn.com/2018/11/27/5-41/ -O 44.htm
wget https://wanderinginn.com/2018/12/01/5-42/ -O 45.htm
wget https://wanderinginn.com/2018/12/04/5-43/ -O 46.htm
wget https://wanderinginn.com/2018/12/06/interlude-niers/ -O 47.htm
wget https://wanderinginn.com/2018/12/08/5-44/ -O 48.htm
wget https://wanderinginn.com/2018/12/11/5-45/ -O 49.htm
wget https://wanderinginn.com/2018/12/15/5-46/ -O 50.htm
wget https://wanderinginn.com/2018/12/18/5-47-g/ -O 51.htm
wget https://wanderinginn.com/2018/12/22/5-48-g/ -O 52.htm
wget https://wanderinginn.com/2018/12/25/5-49/ -O 53.htm
wget https://wanderinginn.com/2018/12/29/5-50-g/ -O 54.htm
wget https://wanderinginn.com/2018/12/30/interlude-bird/ -O 55.htm
wget https://wanderinginn.com/2019/01/08/5-51-g/ -O 56.htm
wget https://wanderinginn.com/2019/01/12/5-52/ -O 57.htm
wget https://wanderinginn.com/2019/01/15/5-53/ -O 58.htm
wget https://wanderinginn.com/2019/01/19/5-54/ -O 59.htm
wget https://wanderinginn.com/2019/01/22/5-54-2/ -O 60.htm
wget https://wanderinginn.com/2019/01/26/interlude-krshia/ -O 61.htm
wget https://wanderinginn.com/2019/01/29/5-55-g/ -O 62.htm
wget https://wanderinginn.com/2019/02/02/5-56-g/ -O 63.htm
wget https://wanderinginn.com/2019/02/05/5-57/ -O 64.htm
wget https://wanderinginn.com/2019/02/09/5-58/ -O 65.htm
wget https://wanderinginn.com/2019/02/12/5-59/ -O 66.htm
wget https://wanderinginn.com/2019/02/16/interlude-pebblesnatch-and-garry/ -O 67.htm
wget https://wanderinginn.com/2019/02/16/5-60/ -O 68.htm
wget https://wanderinginn.com/2019/02/19/5-61/ -O 69.htm
wget https://wanderinginn.com/2019/02/26/5-62/ -O 70.htm
wget https://wanderinginn.com/2019/03/02/interlude-5/ -O 71.htm
```
