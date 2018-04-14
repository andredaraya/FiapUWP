using System;
using System.Threading.Tasks;
using Windows.Storage;
using Windows.Storage.Pickers;
using Windows.Storage.Streams;

namespace FIAPMinhasReceitas.UWP.Services
{
    public static class StorageService
    {
        public static async Task<byte[]> CarregarImagem()
        {
            var picker = new FileOpenPicker
            {
                ViewMode = PickerViewMode.Thumbnail,
                SuggestedStartLocation = PickerLocationId.PicturesLibrary
            };

            picker.FileTypeFilter.Add(".jpg");

            StorageFile file = await picker.PickSingleFileAsync();

            if (file != null)
            {
                var buffer = await FileIO.ReadBufferAsync(file);

                using (DataReader reader = DataReader.FromBuffer(buffer))
                {
                    var imageBytes = new byte[buffer.Length];

                    reader.ReadBytes(imageBytes);

                    return imageBytes;
                }
            }
            else
            {
                return null;
            }
        }
    }
}
