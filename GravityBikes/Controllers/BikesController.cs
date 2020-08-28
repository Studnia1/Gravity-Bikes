using AutoMapper;
using CloudinaryDotNet;
using CloudinaryDotNet.Actions;
using GravityBikes.Data;
using GravityBikes.Data.Models;
using GravityBikes.Dtos;
using GravityBikes.Helpers;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace GravityBikes.Controllers
{

    [ApiController]
    [Route("api/[controller]")]
    public class BikesController : ControllerBase
    {
        private readonly IBikeRentsRespository _repo;
        private readonly IMapper _mapper;
        private readonly IOptions<CloudinarySettings> _cloudinaryConfig;
        private Cloudinary _cloudinary;
        public BikesController(IBikeRentsRespository repo, IMapper mapper, IOptions<CloudinarySettings> cloudinaryConfig)
        {
            _repo = repo;
            _mapper = mapper;
            _cloudinaryConfig = cloudinaryConfig;

            Account acc = new Account(
            _cloudinaryConfig.Value.CloudName,
            _cloudinaryConfig.Value.ApiKey,
            _cloudinaryConfig.Value.ApiSecret
);

            _cloudinary = new Cloudinary(acc);
        }
        [AllowAnonymous]
        [HttpGet]
        public async Task<IActionResult> GetBikes()
        {
            var bikes = await _repo.GetBikes();
            var bikesToReturn = _mapper.Map<IEnumerable<BikesForListDto>>(bikes);

            return Ok(bikesToReturn);
        }
        [AllowAnonymous]
        [HttpGet("{id}")]
        public async Task<IActionResult> GetBike(int id)
        {
            var bike = await _repo.GetBike(id);
            var bikeToReturn = _mapper.Map<BikesForListDto>(bike);

            return Ok(bikeToReturn);
        }
        [AllowAnonymous]
        [HttpPost("availablebikes")]
        public async Task<IActionResult> AvailableBikes(BikesAvaiable bikesAvaiable)
        {
            var bike = await _repo.AvailableBikes(bikesAvaiable.Model, bikesAvaiable.Size);
            return Ok(bike);
        }
        [AllowAnonymous]
        [HttpPost("newbike")]
        public async Task<IActionResult> AddNewBike([FromForm]BikeForCreationDto bikeForCreationDto)
        {
            var file = bikeForCreationDto.file;
            var uploadResult = new ImageUploadResult();

            if (file.Length > 0)
            {
                using (var stream = file.OpenReadStream())
                {
                    var uploadParams = new ImageUploadParams()
                    {
                        File = new FileDescription(file.Name, stream),
                        Transformation = new Transformation()
                            .Width(500).Height(500).Crop("fill").Gravity("face")
                    };

                    uploadResult = _cloudinary.Upload(uploadParams);
                }
            }

            bikeForCreationDto.Url = uploadResult.Url.ToString();
            bikeForCreationDto.PublicId = uploadResult.PublicId;

            if (bikeForCreationDto.sCount > 0) 
            {
                for (int i = 1; i <= bikeForCreationDto.sCount; i++)
                {
                    var smallBikeToCreate = new Bike
                    {
                        BikePrice = bikeForCreationDto.bikePrice,
                        BikeModel = bikeForCreationDto.bikeModel,
                        BikeSize = 0,
                        BikeDescription = bikeForCreationDto.description,
                        Url = bikeForCreationDto.Url,
                        PublicId = bikeForCreationDto.PublicId
                    };
                    if (bikeForCreationDto.isMale)
                        smallBikeToCreate.BikeGender = 1;
                    else if (bikeForCreationDto.isFemale)
                        smallBikeToCreate.BikeGender = 2;
                    else
                        smallBikeToCreate.BikeGender = 3;
                    var registeredBike = await _repo.NewBike(smallBikeToCreate);
                }

            }
            if (bikeForCreationDto.mCount > 0)
            {
                for (int i = 1; i <= bikeForCreationDto.mCount; i++)
                {
                    var mediumBikeToCreate = new Bike
                    {
                        BikePrice = bikeForCreationDto.bikePrice,
                        BikeModel = bikeForCreationDto.bikeModel,
                        BikeSize = 1,
                        BikeDescription = bikeForCreationDto.description,
                        Url = bikeForCreationDto.Url,
                        PublicId = bikeForCreationDto.PublicId
                    };
                    if (bikeForCreationDto.isMale)
                        mediumBikeToCreate.BikeGender = 1;
                    else if (bikeForCreationDto.isFemale)
                        mediumBikeToCreate.BikeGender = 2;
                    else
                        mediumBikeToCreate.BikeGender = 3;
                    var registeredBike = await _repo.NewBike(mediumBikeToCreate);
                }
            }
            if (bikeForCreationDto.lCount > 0)
            {
                for (int i = 1; i <= bikeForCreationDto.lCount; i++)
                {
                    var largeBikeToCreate = new Bike
                    {
                        BikePrice = bikeForCreationDto.bikePrice,
                        BikeModel = bikeForCreationDto.bikeModel,
                        BikeSize = 2,
                        BikeDescription = bikeForCreationDto.description,
                        Url = bikeForCreationDto.Url,
                        PublicId = bikeForCreationDto.PublicId
                    };
                    if (bikeForCreationDto.isMale)
                        largeBikeToCreate.BikeGender = 1;
                    else if (bikeForCreationDto.isFemale)
                        largeBikeToCreate.BikeGender = 2;
                    else
                        largeBikeToCreate.BikeGender = 3;
                    var registeredBike = await _repo.NewBike(largeBikeToCreate);
                }
            }
            if (bikeForCreationDto.xlCount > 0)
            {
                for (int i = 1; i <= bikeForCreationDto.xlCount; i++)
                {
                    var xLargeBikeToCreate = new Bike
                    {
                        BikePrice = bikeForCreationDto.bikePrice,
                        BikeModel = bikeForCreationDto.bikeModel,
                        BikeSize = 3,
                        BikeDescription = bikeForCreationDto.description,
                        Url = bikeForCreationDto.Url,
                        PublicId = bikeForCreationDto.PublicId
                    };
                    if (bikeForCreationDto.isMale)
                        xLargeBikeToCreate.BikeGender = 1;
                    else if (bikeForCreationDto.isFemale)
                        xLargeBikeToCreate.BikeGender = 2;
                    else
                        xLargeBikeToCreate.BikeGender = 3;
                    var registeredBike = await _repo.NewBike(xLargeBikeToCreate);

                }
            }
            return StatusCode(201);

        }
    }
}
