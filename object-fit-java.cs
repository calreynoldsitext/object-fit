ConverterProperties props = new ConverterProperties().SetBaseUri("image_directory/");
HtmlConverter.ConvertToPdf(new FileStream(src, FileMode.Open), new FileStream(dest, FileMode.Create), props);
