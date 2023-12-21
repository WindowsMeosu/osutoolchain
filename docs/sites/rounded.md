---
tags: site, website, pages, html, css, javascript
---

# Website Usage

## Rounded Images

* Requires: CSS, HTML.

Rounded images are pretty self-explanatory, they are circular images and in most cases are used as a way of displaying avatar images. Need to create a rounded image as a way of displaying yours or someone's (osu!) profile picture? If you're looking at this page then I assume the answer is yes. If no, then fuck off (no offense).

```css
img[src$="rounded"] {
display: block;
margin: 0 auto;
border-radius: 50%;
max-width: 10%;
max-height: 30%
}
```

I'm guessing you want me to go over the above CSS snippet and pretty much explain everything. No worries, I'll sum it very quicky:

***You don't need a full explanation of every possible fucking detail other than the fact that it rounds images.***\
Anyway, all that's left is a little HTML. (more accurately, markdown with a little html mixed in) I shouldn't have to elaborate anything else beyond this.

```md
<link rel="stylesheet" href="../../site usage/css/rounded-images.css">

![Windows_Me](https://a.ppy.sh/28893698_q.jpeg#rounded "Windows_Me")
```

Make sure you based it off your own directory.

Example:

<link rel="stylesheet" href="../../site usage/css/rounded-images.css">

![Windows_Me](https://a.ppy.sh/28893698_q.jpeg#rounded "Windows_Me")

If you don't want it centered, using the following CSS instead:

```css
img[src$="rounded"] {
display: block;
border-radius: 50%;
max-width: 9%;
max-height: 10%		
}
```


<link rel="stylesheet" href="../../site usage/css/rounded-imagesnc.css">

![Windows_Me](https://a.ppy.sh/28893698_q.jpeg#roundednc "Windows_Me")
