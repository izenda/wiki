#14.3 Advanced FORMS Concepts

### Nesting Reports and Forms

By using double square brackets, you can call another form or report.  If you have a form called City Data in the Sub-reports folder, you would type ``[[Subreports/City Data]]`` in order to drop that form into the form you are building.  This works whether the called report is a form or a non-form report.

Caution is recommended when designing nested sub-reports and forms.  When you call a report from inside of a master report, you are essentially using a query to run another query (and by result, all queries that might be contained within that nested query).  It is thus possible to build a chain of nested reports that can cause severe performance issues.  

The flexibility of nesting reports and forms is most desirable for many small cases, in which sub-reports only exhibit a very small performance hit. Complex or multi-level nested reports may experience significant performance issues; in these cases it is best to find a way to achieve your goal without using sub-reports.

### Repeater Tag

If you have content that you want to repeat within a form, you don’t need to use a nested sub-form.   By enclosing this content with the ``[repeater]`` tag, the forms engine will repeat that content until it is exhausted. 

In this example, we would generate a table with 1+n rows.  The first row is static and displays text in two cells.  The second row is within a repeater, which means that it will generate _**n**_ times where _**n**_ is the number of valid ``[PersonID]`` entries.  This repeater has a nested repeater in the second cell, which will populate all valid ``[Name]`` for each ``[PersonID]``.  

```html
<table>
  <tr>
    <td>Person</td>
    <td>Certs</td>
  </tr>
[repeater]
  <tr>
    <td>[PersonID]</td>
    <td>[repeater][Name], [/repeater]</td>
  </tr>
[/repeater]
</table>
```

All of these count against the Records display limit. If you have four ``[PersonID]`` and each has three ``[Name]`` entries, then the form would count as 12 records.  This means that if you set it to only display 10 records, the form would not completely generate.

You can only nest one set of repeaters at a time.  This is a correct use:

```html
[repeater]

    [repeater]

        [repeater]

        [/repeater]
    
    [/repeater]

[/repeater]
```

**And this is an incorrect use:**

```html
[repeater]

    [repeater]

    [/repeater]

    [repeater]

    [/repeater]

[/repeater]
```

**Video tutorial:** http://blog.izenda.com/quick-tutorial-how-to-use-the-repeater-tag/ **or here:** http://screencast.com/t/6RwYd7sKKKh




Let us know what features of Izenda Forms we can add to our Video Tutorials online. We want to make sure we’re answering YOUR questions!

---

[[14.0 Izenda FORMS]]

[[User Guides|http://wiki.izenda.us/FAQ/UserGuides]]