ConverterProperties props = new ConverterProperties().setBaseUri("image_directory/");
HtmlConverter.convertToPdf(new FileInputStream(ORIG), new FileOutputStream(DEST), props);
