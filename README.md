# Liquid + Markdown = LiquidMarkdown #

What is better than Markdown? Markdown with templates!

Mix of Markdown ([Markdown.Xaml](https://github.com/theunrepentantgeek/Markdown.XAML) in this case) and Liquid ([dotliquid](https://github.com/dotliquid/dotliquid) template processor.

# Example #
```
{% assign itemsString = "apples: This - is - how  - we  - do - it, oranges: no oranges here!" %}
Original string is **{{ itemsString }}**
By splitting up the string we can iterate through it

{% assign items = itemsString | split: ", " %}
{% for x in items %}
{% assign k = x | split: ":" %}
## {{ k[0] }} ##
{{ k[1] }}
{% endfor %}
```

# Result

Original string is **apples: This - is - how  - we  - do - it, oranges: no oranges here!**
By splitting up the string we can iterate through it
## apples ##
This - is - how  - we  - do - it
## oranges ##
no oranges here!

